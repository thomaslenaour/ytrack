export const tests = []
const t = (f) => tests.push(f)

t(({ eq, rows }) => eq(rows, expected))

const expected = [ 
  {
    EmployeeId: 1,
    LastName: 'Adams',
    FirstName: 'Andrew',
    Title: 'General Manager',
    ReportsTo: null,
    BirthDate: '1962-02-18 00:00:00',
    HireDate: '2002-08-14 00:00:00',
    Address: '11120 Jasper Ave NW',
    City: 'Edmonton',
    State: 'AB',
    Country: 'Canada',
    PostalCode: 'T5K 2N1',
    Phone: '+1 (780) 428-9482',
    Fax: '+1 (780) 428-3457',
    Email: 'andrew@chinookcorp.com'
  },
  {
    EmployeeId: 2,
    LastName: 'Edwards',
    FirstName: 'Nancy',
    Title: 'Sales Manager',
    ReportsTo: 1,
    BirthDate: '1958-12-08 00:00:00',
    HireDate: '2002-05-01 00:00:00',
    Address: '825 8 Ave SW',
    City: 'Calgary',
    State: 'AB',
    Country: 'Canada',
    PostalCode: 'T2P 2T3',
    Phone: '+1 (403) 262-3443',
    Fax: '+1 (403) 262-3322',
    Email: 'nancy@chinookcorp.com'
  },
  {
    EmployeeId: 3,
    LastName: 'Peacock',
    FirstName: 'Jane',
    Title: 'Sales Support Agent',
    ReportsTo: 2,
    BirthDate: '1973-08-29 00:00:00',
    HireDate: '2002-04-01 00:00:00',
    Address: '1111 6 Ave SW',
    City: 'Calgary',
    State: 'AB',
    Country: 'Canada',
    PostalCode: 'T2P 5M5',
    Phone: '+1 (403) 262-3443',
    Fax: '+1 (403) 262-6712',
    Email: 'jane@chinookcorp.com'
  },
  {
    EmployeeId: 4,
    LastName: 'Park',
    FirstName: 'Margaret',
    Title: 'Sales Support Agent',
    ReportsTo: 2,
    BirthDate: '1947-09-19 00:00:00',
    HireDate: '2003-05-03 00:00:00',
    Address: '683 10 Street SW',
    City: 'Calgary',
    State: 'AB',
    Country: 'Canada',
    PostalCode: 'T2P 5G3',
    Phone: '+1 (403) 263-4423',
    Fax: '+1 (403) 263-4289',
    Email: 'margaret@chinookcorp.com'
  },
  {
    EmployeeId: 5,
    LastName: 'Johnson',
    FirstName: 'Steve',
    Title: 'Sales Support Agent',
    ReportsTo: 2,
    BirthDate: '1965-03-03 00:00:00',
    HireDate: '2003-10-17 00:00:00',
    Address: '7727B 41 Ave',
    City: 'Calgary',
    State: 'AB',
    Country: 'Canada',
    PostalCode: 'T3B 1Y7',
    Phone: '1 (780) 836-9987',
    Fax: '1 (780) 836-9543',
    Email: 'steve@chinookcorp.com'
  },
  {
    EmployeeId: 6,
    LastName: 'Mitchell',
    FirstName: 'Michael',
    Title: 'IT Manager',
    ReportsTo: 1,
    BirthDate: '1973-07-01 00:00:00',
    HireDate: '2003-10-17 00:00:00',
    Address: '5827 Bowness Road NW',
    City: 'Calgary',
    State: 'AB',
    Country: 'Canada',
    PostalCode: 'T3B 0C5',
    Phone: '+1 (403) 246-9887',
    Fax: '+1 (403) 246-9899',
    Email: 'michael@chinookcorp.com'
  },
  {
    EmployeeId: 7,
    LastName: 'King',
    FirstName: 'Robert',
    Title: 'IT Staff',
    ReportsTo: 6,
    BirthDate: '1970-05-29 00:00:00',
    HireDate: '2004-01-02 00:00:00',
    Address: '590 Columbia Boulevard West',
    City: 'Lethbridge',
    State: 'AB',
    Country: 'Canada',
    PostalCode: 'T1K 5N8',
    Phone: '+1 (403) 456-9986',
    Fax: '+1 (403) 456-8485',
    Email: 'robert@chinookcorp.com'
  },
  {
    EmployeeId: 8,
    LastName: 'Callahan',
    FirstName: 'Laura',
    Title: 'IT Staff',
    ReportsTo: 6,
    BirthDate: '1968-01-09 00:00:00',
    HireDate: '2004-03-04 00:00:00',
    Address: '923 7 ST NW',
    City: 'Lethbridge',
    State: 'AB',
    Country: 'Canada',
    PostalCode: 'T1H 1Y8',
    Phone: '+1 (403) 467-3351',
    Fax: '+1 (403) 467-8772',
    Email: 'laura@chinookcorp.com'
  }
]

Object.freeze(tests)