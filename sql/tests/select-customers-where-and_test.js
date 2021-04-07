export const tests = []
const t = (f) => tests.push(f)

t(({ eq, rows }) => eq(rows, expected))

const expected = [
  { FirstName: 'Luís', LastName: 'Gonçalves' },
  { FirstName: 'Eduardo', LastName: 'Martins' },
  { FirstName: 'Alexandre', LastName: 'Rocha' }
]

Object.freeze(tests)