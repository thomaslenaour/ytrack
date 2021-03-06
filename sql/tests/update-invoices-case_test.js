export const tests = []
const t = (f) => tests.push(f)

t(({ eq, db }) => eq(
  db.prepare(`SELECT Total FROM invoices LIMIT 100`).all(),
  expected
))

const expected = [
  { Total: 2.98 },
  { Total: 4.96 },
  { Total: 6.94 },
  { Total: 9.91 },
  { Total: 18.86 },
  { Total: 1.99 },
  { Total: 2.98 },
  { Total: 4.98 },
  { Total: 6.96 },
  { Total: 6.94 },
  { Total: 9.91 },
  { Total: 14.86 },
  { Total: 5.99 },
  { Total: 6.98 },
  { Total: 6.98 },
  { Total: 8.96 },
  { Total: 10.940000000000001 },
  { Total: 9.91 },
  { Total: 16.86 },
  { Total: 1.99 },
  { Total: 2.98 },
  { Total: 2.98 },
  { Total: 4.96 },
  { Total: 6.94 },
  { Total: 9.91 },
  { Total: 18.86 },
  { Total: 1.99 },
  { Total: 2.98 },
  { Total: 2.98 },
  { Total: 4.96 },
  { Total: 8.940000000000001 },
  { Total: 9.91 },
  { Total: 14.86 },
  { Total: 1.99 },
  { Total: 2.98 },
  { Total: 2.98 },
  { Total: 8.96 },
  { Total: 10.940000000000001 },
  { Total: 13.91 },
  { Total: 14.86 },
  { Total: 1.99 },
  { Total: 2.98 },
  { Total: 2.98 },
  { Total: 4.96 },
  { Total: 6.94 },
  { Total: 9.91 },
  { Total: 14.86 },
  { Total: 1.99 },
  { Total: 2.98 },
  { Total: 2.98 },
  { Total: 4.96 },
  { Total: 6.94 },
  { Total: 9.91 },
  { Total: 14.86 },
  { Total: 1.99 },
  { Total: 2.98 },
  { Total: 2.98 },
  { Total: 4.96 },
  { Total: 10.940000000000001 },
  { Total: 13.91 },
  { Total: 14.86 },
  { Total: 1.99 },
  { Total: 2.98 },
  { Total: 2.98 },
  { Total: 4.96 },
  { Total: 6.94 },
  { Total: 9.91 },
  { Total: 14.86 },
  { Total: 5.99 },
  { Total: 6.98 },
  { Total: 6.98 },
  { Total: 4.96 },
  { Total: 6.94 },
  { Total: 11.91 },
  { Total: 14.86 },
  { Total: 1.99 },
  { Total: 2.98 },
  { Total: 2.98 },
  { Total: 4.96 },
  { Total: 6.94 },
  { Total: 13.91 },
  { Total: 18.86 },
  { Total: 3.99 },
  { Total: 4.98 },
  { Total: 2.98 },
  { Total: 4.96 },
  { Total: 7.94 },
  { Total: 18.91 },
  { Total: 19.86 },
  { Total: 5.99 },
  { Total: 6.98 },
  { Total: 6.98 },
  { Total: 8.96 },
  { Total: 6.94 },
  { Total: 9.91 },
  { Total: 22.86 },
  { Total: 2.99 },
  { Total: 4.98 },
  { Total: 4.98 },
  { Total: 4.96 }
]

Object.freeze(tests)