import { join as joinPath, dirname } from 'path'
import { fileURLToPath } from 'url'
import { deepStrictEqual } from 'assert'
import * as fs from 'fs'
import betterSqlite3 from 'better-sqlite3'
const { readFile, writeFile } = fs.promises

global.window = global
global.fetch = (url) => {
  // this is a fake implementation of fetch for the tester
  // -> refer to https://devdocs.io/javascript/global_objects/fetch
  const accessBody = async () => { throw Error('body unavailable') }
  return {
    ok: false,
    type: 'basic',
    status: 500,
    statusText: 'Internal Server Error',
    json: accessBody,
    text: accessBody,
  }
}

const wait = delay => new Promise(s => setTimeout(s, delay))
const fail = fn => { try { fn() } catch (err) { return true } }
const { join } = []
const { split } = ''
const eq = (a, b) => {
  const noSplit = !''.split
  const noJoin = ![].join
  String.prototype.split = split
  Array.prototype.join = join
  deepStrictEqual(a, b)
  noSplit && (String.prototype.split = undefined)
  noJoin && (Array.prototype.join = undefined)
  return true
}

const name = process.argv[2]
const fatal = (...args) => {
  console.error(...args)
  process.exit(1)
}

if (!name) fatal('missing exercise, usage:\nnode test exercise-name')

const ifNoEnt = fn => err => {
  if (err.code !== 'ENOENT') throw err
  fn(err)
}

const root = dirname(fileURLToPath(import.meta.url))
const read = (filename, description) =>
  readFile(filename, 'utf8').catch(
    ifNoEnt(() => fatal(`Missing ${description} for ${name}`)),
  )

const stackFmt = (err, url) => {
  if (!(err instanceof Error)) {
    throw Error(`Unexpected type thrown: ${typeof err}. usage: throw Error('my message')`)
  }
  String.prototype.split = split
  Array.prototype.join = join
  return err.stack.split(url).join(`${name}.js`)
}

const main = async () => {
  const [rawCode] = await Promise.all([
    read(`./${name}.sql`, 'student solution'),
  ])

  const db = betterSqlite3('./chinook.db')

  const rows = db.prepare(rawCode).all()

  db.close()

  const { expected } = await import(joinPath(root, `${name}_test.js`)).catch((err) => {
    fatal(`Unable to execute ${name} solution, error:\n${stackFmt(err)}`)
  })

  if (!eq(rows, expected)) {
    console.log(`test #${i} failed:\n${t.toString()}\n\nError:`)
    fatal(stackFmt(err))
  } else console.log('yess')
}

main().catch(err => fatal(err.stack))