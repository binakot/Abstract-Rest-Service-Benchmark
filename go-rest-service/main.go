package main

import (
	"github.com/gorilla/mux"
	"log"
	"net/http"
)

func TestEndpoint(w http.ResponseWriter, r *http.Request) {
	w.Header().Set("Content-Type", "text/plain")
	w.Write([]byte("Hello, World!"))
}

func main() {
	router := mux.NewRouter()
	router.HandleFunc("/api/test", TestEndpoint).Methods("GET")
	log.Fatal(http.ListenAndServe(":8080", router))
}
