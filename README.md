# This is my coursework at Tallinn Polytechnic School for Distributed Applications.

---

## List of API GET calls

This API has a call to get parts data and 4 calls to sort the data.

Description | Call
--- | ---
All parts | /api/parts
Set page numbers | /api/parts?Page={number}
Set page size | /api/parts?pageSize={number}
Search by name | /api/parts?Name={Name}
Sort by price | /api/parts?Sort=price

## Response body
    {
        "serial": "99182355519",
        "name": "Suverehv Freemont 235/55R19",
        "price": 165,
        "priceVAT": 198,
        "carModel": "0",
        "stock": {
            "Tallinn": 0,
            "Tartu": 0,
            "Pärnu": 0,
            "Kohtla-Järve": 4
        }
    }