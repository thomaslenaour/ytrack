export const tests = []
const t = (f) => tests.push(f)

t(async ({ eq, db }) => eq(
  (await db.query(`SELECT * FROM playlists WHERE Name = 'lol'`))[0],
  [{ PlaylistId: 19, Name: 'lol' }]
))

Object.freeze(tests)