export const tests = []
const t = (f) => tests.push(f)

t(({ eq, rows }) => eq(rows, expected))

const expected = [{ Name: 'Movies' }, { Name: 'Music' }, { Name: 'Music Videos' }]

Object.freeze(tests)