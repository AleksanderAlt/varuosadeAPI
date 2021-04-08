# This is my coursework at Tallinn Polytechnic School for Distributed Applications.

---

## List of API calls

*GET All parts /api/parts
*GET Set page numbers /api/parts?Page={number}
*GET Set page size /api/parts?pageSize={number}
*GET Search by name /api/parts?Name={Name}
*GET Sort by price /api/parts?Sort=price

## Response body
    {
        "serial": "99201956515",
        "name": "Suverehv Nexen Blue Eco",
        "price": 33.33333,
        "priceVAT": 40,
        "carModel": "0",
        "stock": {
            "Tallinn": 0,
            "Tartu": 0,
            "Pärnu": 0,
            "Kohtla-Järve": 0
        }
    }