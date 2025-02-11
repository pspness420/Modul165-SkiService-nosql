document.addEventListener("DOMContentLoaded", () => {
    const token = localStorage.getItem("jwtToken");
    const authLink = document.querySelector("li.nav-item a[href='registration.html']");
    const navLinks = document.querySelector("ul.navbar-nav");

    if (token) {
        const payload = JSON.parse(atob(token.split(".")[1]));
        const userRole = payload.role;

        // Rollenbasierte Links hinzufügen
        if (userRole === "Admin") {
            navLinks.innerHTML += `<li class="nav-item"><a class="nav-link" href="admin.html">Admin-Bereich</a></li>`;
        } else if (userRole === "Mitarbeiter") {
            navLinks.innerHTML += `<li class="nav-item"><a class="nav-link" href="mitarbeiter.html">Mitarbeiter-Bereich</a></li>`;
        } else if (userRole === "Kunde") {
            navLinks.innerHTML += `<li class="nav-item"><a class="nav-link" href="kunde.html">Kundencenter</a></li>`;
        }

        // Logout-Option
        authLink.innerHTML = `Logout`;
        authLink.addEventListener("click", () => {
            localStorage.removeItem("jwtToken");
            location.href = "index.html";
        });
    } else {
        authLink.innerHTML = `Login`;
        authLink.href = "login.html";
    }
});
