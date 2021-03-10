export const tests = []
const t = (f) => tests.push(f)

t(async ({ eq, db }) => eq(
  db.prepare(`SELECT * FROM playlists WHERE Name = 'lol'`).get(),
  { PlaylistId: 19, Name: 'lol' }
))

Object.freeze(tests)