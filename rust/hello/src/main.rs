extern crate iron;
extern crate router;

use iron::prelude::*;
use iron::status;
use router::Router;

fn main() {
    let mut router = Router::new();
    router.get("/api/test", hello_world, "index");

    fn hello_world(_: &mut Request) -> IronResult<Response> {
        Ok(Response::with((status::Ok, "Hello, World!")))
    }

    let _server = Iron::new(hello_world).http("0.0.0.0:8080").unwrap();
    println!("On 8080");
}
