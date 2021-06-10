## is-big-order

### Instructions

The billing service asks you to collect information on the number of products purchased on invoices that have the number: `32, 45, 89, 33, 55`.

You must select the `InvoiceId`, the number of products purchased with the alias` NbItems`.
You must also add an alias `IsBigOrder` which will vary depending on the number of products:

- If the number of items is equal or less than 1 then print `Small Order`
- If the number of items is equal or less than 10 then print `Normal Order`
- If the number of items is greater than 10 then print `Big Order`

**For this exercise, you must do a subquery !**

The results should be sorted by invoice number in ascending order.

### Expected result

![Expected Result](https://thomaslenaour.github.io/ytrack/subjects/is-big-order/expected.png)

### Notions

- [sql.sh/cours/jointures/inner-join](https://sql.sh/cours/jointures/inner-join)
- [sql.sh/fonctions/agregation/count](https://sql.sh/fonctions/agregation/count)
- [sql.sh/cours/case](https://sql.sh/cours/case)
- [sql.sh/cours/order-by](https://sql.sh/cours/order-by)
- [sql.sh/cours/group-by](https://sql.sh/cours/group-by)
