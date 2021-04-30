export const tests = []
const t = (f) => tests.push(f)

t(({ eq, query }) => eq((query.toUpperCase().match(/SELECT/g) || []).length > 0, true))
t(({ eq, db }) => eq(db.prepare(
  `SELECT
	  *
  FROM
    tracks
  WHERE
    AlbumId BETWEEN 80 AND 200 AND Composer IS NULL`
).all(), []))

Object.freeze(tests)