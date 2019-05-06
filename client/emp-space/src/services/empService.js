const BASE_URL = "https://localhost:44327/";

export function GetAllEmp() {
    var url = BASE_URL + "api/EmpSpace";

    return fetch(url).then(response => response.json());
}

// export function GetEmp(id) {
//     var url = BASE_URL + "api/EmpSpace/" + id;

//     return fetch(url).then(response => response.json());
// }