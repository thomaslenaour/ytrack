export const tests = []
const t = (f) => tests.push(f)

t(({ eq, rows, sortObjectsInArray }) => eq(rows, sortObjectsInArray(expected)))

const expected = [
  { FirstName: 'Luís', LastName: 'Gonçalves' },
  { FirstName: 'Eduardo', LastName: 'Martins' },
  { FirstName: 'Alexandre', LastName: 'Rocha' }
]

Object.freeze(tests)