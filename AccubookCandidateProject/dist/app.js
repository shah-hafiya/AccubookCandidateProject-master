class App {
    constructor() {
        this.bookings = ko.observableArray([]);
        this.newBooking = new Booking(0, "", new Date(), new Date(), 0, 0, "");
        this.reviews = ko.observableArray([
            new Review('Henry K.', 'I enjoyed my stay, the view was pleasant.', 4),
            new Review('John M.', 'The location was beautiful!', 3),
            new Review('Mary D.', 'Breakfast was cold. Very dissapointed.', 1),
        ]);
    }
    init() {
        ko.applyBindings(this, document.documentElement);
    }
    getBookings() {
    }
    saveBooking(newBooking) {
    }
    averageRating() {
        return 0;
    }
    addReview() {
        alert('Not implemented yet!');
    }
}
class Booking {
    constructor(id, name, arrival, departure, rate, hotelId, hotelName) {
        this.id = id;
        this.name = name;
        this.arrival = arrival;
        this.departure = departure;
        this.rate = rate;
        this.hotelId = hotelId;
        this.hotelName = hotelName;
    }
    getTotal() {
        return 0;
    }
}
class Review {
    constructor(name, message, rating) {
        this.name = name;
        this.message = message;
        this.rating = +rating;
    }
}
