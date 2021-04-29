export const tests = []
const t = (f) => tests.push(f)

t(({ eq, query }) => eq((query.toUpperCase().match(/SELECT/g) || []).length > 1, true))
t(({ eq, rows, sortObjectsInArray }) => eq(rows, sortObjectsInArray(expected)))

const expected = [
  { InvoiceId: 32, NbItems: 9, IsBigOrder: 'Normal Order' },
  { InvoiceId: 33, NbItems: 14, IsBigOrder: 'Big Order' },
  { InvoiceId: 45, NbItems: 6, IsBigOrder: 'Normal Order' },
  { InvoiceId: 55, NbItems: 1, IsBigOrder: 'Small Order' },
  { InvoiceId: 89, NbItems: 14, IsBigOrder: 'Big Order' }
]

Object.freeze(tests)