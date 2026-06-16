/******************************************************************
  1. JAVASCRIPT BASICS & SETUP
******************************************************************/

console.log("Welcome to the Community Portal");

window.onload = () => {
    alert("Community Portal Loaded Successfully!");
};

/******************************************************************
  2. SYNTAX, DATA TYPES & OPERATORS
******************************************************************/

const eventName = "Music Festival";
const eventDate = "2026-08-15";
let availableSeats = 50;

console.log(`Event: ${eventName} | Date: ${eventDate}`);

function registerSeat() {
    availableSeats--;
    console.log(`Remaining Seats: ${availableSeats}`);
}

/******************************************************************
  3. CONDITIONALS, LOOPS & ERROR HANDLING
******************************************************************/

const events = [
    { id: 1, name: "Music Festival", seats: 20, date: "2026-08-15", category: "Music" },
    { id: 2, name: "Food Fair", seats: 0, date: "2026-07-10", category: "Food" }
];

events.forEach(event => {
    if (event.seats > 0) {
        console.log(event.name);
    }
});

function safeRegistration(event) {
    try {
        if (event.seats <= 0) {
            throw new Error("No seats available");
        }

        event.seats--;
        console.log("Registration Successful");

    } catch (error) {
        console.error(error.message);
    }
}

/******************************************************************
  4. FUNCTIONS, SCOPE, CLOSURES, HIGHER-ORDER FUNCTIONS
******************************************************************/

function addEvent(eventObj) {
    events.push(eventObj);
}

function registerUser(eventId) {
    const event = events.find(e => e.id === eventId);

    if (event && event.seats > 0) {
        event.seats--;
    }
}

function filterEventsByCategory(category) {
    return events.filter(event => event.category === category);
}

// Closure Example
function registrationTracker(category) {
    let totalRegistrations = 0;

    return function () {
        totalRegistrations++;
        console.log(`${category}: ${totalRegistrations}`);
    };
}

const musicTracker = registrationTracker("Music");

// Higher Order Function
function searchEvents(callback) {
    return callback(events);
}

/******************************************************************
  5. OBJECTS & PROTOTYPES
******************************************************************/

class Event {
    constructor(id, name, seats, category) {
        this.id = id;
        this.name = name;
        this.seats = seats;
        this.category = category;
    }
}

Event.prototype.checkAvailability = function () {
    return this.seats > 0;
};

const workshop = new Event(
    3,
    "Baking Workshop",
    25,
    "Workshop"
);

console.log(Object.entries(workshop));

/******************************************************************
  6. ARRAYS & METHODS
******************************************************************/

events.push({
    id: 4,
    name: "Rock Concert",
    seats: 100,
    category: "Music"
});

const musicEvents = events.filter(
    event => event.category === "Music"
);

const displayCards = events.map(
    event => `Workshop on ${event.name}`
);

console.log(displayCards);

/******************************************************************
  7. DOM MANIPULATION
******************************************************************/

const eventContainer =
    document.querySelector("#eventContainer");

function displayEvents() {

    eventContainer.innerHTML = "";

    events.forEach(event => {

        const card = document.createElement("div");

        card.innerHTML = `
            <h3>${event.name}</h3>
            <p>Seats: ${event.seats}</p>
            <button onclick="register(${event.id})">
                Register
            </button>
        `;

        eventContainer.appendChild(card);
    });
}

function register(id) {
    registerUser(id);
    displayEvents();
}

/******************************************************************
  8. EVENT HANDLING
******************************************************************/

document.querySelector("#categoryFilter")
    .onchange = function () {

    const selectedCategory = this.value;

    const filtered = events.filter(
        event => event.category === selectedCategory
    );

    console.log(filtered);
};

document.querySelector("#searchBox")
    .addEventListener("keydown", event => {

    console.log(event.target.value);
});

/******************************************************************
  9. ASYNC JS, PROMISES, ASYNC/AWAIT
******************************************************************/

fetch("events.json")
    .then(response => response.json())
    .then(data => console.log(data))
    .catch(error => console.error(error));

// Async Await Version

async function loadEvents() {

    try {

        document.querySelector("#loading")
            .style.display = "block";

        const response = await fetch("events.json");

        const data = await response.json();

        console.log(data);

    } catch (error) {

        console.error(error);

    } finally {

        document.querySelector("#loading")
            .style.display = "none";
    }
}

/******************************************************************
  10. MODERN JAVASCRIPT FEATURES
******************************************************************/

function createEvent(
    name = "New Event",
    seats = 10
) {
    return { name, seats };
}

const sampleEvent = {
    id: 10,
    title: "Dance Show",
    seats: 40
};

const { title, seats } = sampleEvent;

const clonedEvents = [...events];

/******************************************************************
  11. WORKING WITH FORMS
******************************************************************/

document.querySelector("#registrationForm")
.addEventListener("submit", function (event) {

    event.preventDefault();

    const name =
        this.elements["name"].value;

    const email =
        this.elements["email"].value;

    const selectedEvent =
        this.elements["event"].value;

    if (!name || !email) {

        document.querySelector("#error")
            .textContent =
            "Please fill all fields";

        return;
    }

    console.log(name, email, selectedEvent);
});

/******************************************************************
  12. AJAX & FETCH API
******************************************************************/

function submitRegistration(userData) {

    setTimeout(() => {

        fetch(
            "https://jsonplaceholder.typicode.com/posts",
            {
                method: "POST",
                headers: {
                    "Content-Type":
                        "application/json"
                },
                body: JSON.stringify(userData)
            }
        )
        .then(response => response.json())
        .then(data => {

            console.log(data);

            document.querySelector("#message")
                .textContent =
                "Registration Successful";
        })
        .catch(() => {

            document.querySelector("#message")
                .textContent =
                "Registration Failed";
        });

    }, 2000);
}

/******************************************************************
  13. DEBUGGING & TESTING
******************************************************************/

console.log("Form Submission Started");
console.log("Payload:", {
    name: "John",
    email: "john@gmail.com"
});

// Add breakpoints in DevTools
// Check Network Tab
// Verify Request Payload

/******************************************************************
  14. JQUERY & JS FRAMEWORKS
******************************************************************/

$("#registerBtn").click(function () {
    alert("Registered Successfully");
});

$("#eventCard").fadeIn();
$("#eventCard").fadeOut();

/*
Benefit of React/Vue:

1. Component-Based Architecture
2. Faster UI Updates (Virtual DOM)
3. Better State Management
4. Reusable Components
*/