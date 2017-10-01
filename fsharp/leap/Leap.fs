module LeapYear

let isCentury (year: int): bool = year % 100 = 0;
let isLeapCentury (year: int): bool = year % 400 = 0;
let isLeapYear (year: int): bool = isLeapCentury(year) || not (isCentury(year)) && year % 4 = 0;
