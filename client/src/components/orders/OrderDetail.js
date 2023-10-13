import React, { useState, useEffect } from "react";
import { Card, CardTitle, CardSubtitle, CardBody, CardText } from "reactstrap";
import { useParams, Link } from "react-router-dom";
import { getOrderById } from "../../managers/orderManager.js";

export default function OrderDetails() {
  const [order, setOrder] = useState({});
  const { id } = useParams();

  const getOrderDetails = () => {
    getOrderById(id).then(setOrder);
  };

  useEffect(() => {
    getOrderDetails();
  }, [id]);

  if (!order) {
    return (
      <>
        <h2>Order Details</h2>
        <p>Please choose an order...</p>
      </>
    );
  }

  return (
    <>
      <h2>Order Details</h2>
      <Card color="dark" inverse>
        <CardBody>
          <CardTitle tag="h4">Order ID: {order.id}</CardTitle>
          <CardSubtitle>Employee: {order?.employeeRecieverId}</CardSubtitle>
          <CardText>
            Order Date: {new Date(order.timePlaced).toLocaleDateString()}
          </CardText>
          <CardText>Tip: ${order.tipAmount || "N/A"}</CardText>
        </CardBody>
        <Link to={`/pizzas/${order.id}/addpizza`}>Add Pizza</Link>
      </Card>
      <h4>Pizzas</h4>
      {order?.pizzas?.map((pizza, index) => (
        <Card
          outline
          color="success"
          key={index}
          style={{ marginBottom: "4px" }}
        >
          <CardBody>
            <CardTitle tag="h5">Pizza {index + 1}</CardTitle>
            <CardText>Size: {pizza?.pizzaSize?.title}</CardText>
            <CardText>Sauce: {pizza?.sauce?.title}</CardText>
            <CardText>Cheese: {pizza?.cheese?.title}</CardText>
            <CardText>Toppings: {pizza?.pizzaTopping?.map((pizzaTopping) => (
              <div key={pizzaTopping.topping.id}>
                {pizzaTopping.topping.title}
              </div>
            ))}</CardText>
          </CardBody>
        </Card>
      ))}
    </>
  );
}