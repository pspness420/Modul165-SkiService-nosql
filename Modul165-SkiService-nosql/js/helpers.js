export function validateEmail(email) {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
}

export function validatePhone(phone) {
    const phoneRegex = /^\d{3} \d{3} \d{2} \d{2}$/;
    return phoneRegex.test(phone);
}
