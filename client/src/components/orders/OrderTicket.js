import React from "react";
import {
  Card,
  CardBody,
  CardTitle,
  CardText,
  CardSubtitle,
  Button,
} from "reactstrap";

import { useNavigate } from "react-router-dom";

export default function OrderTicket({ order, getAllOrders }) {
  const navigate = useNavigate();

 
  const deleteOrder = (id) => {
    deleteOrder(id) 
      .then(() => {
        getAllOrders();
      })
  };

  return (
    <Card color="dark" outline style={{ marginBottom: "4px" }}>
      <CardBody>
        <CardTitle tag="h5">Order ID: {order.id}</CardTitle>
        <CardSubtitle className="mb-2 text-muted" tag="h6">
          Employee ID: {order.employeeRecieverId}
        </CardSubtitle>
        <CardText>
          Order Date: {new Date(order.timePlaced).toLocaleDateString()}
        </CardText>
        <CardText>Tip: ${order.tipAmount || "N/A"}</CardText>
        <Button
          color="dark"
          onClick={() => {
            navigate(`orders/${order.id}`);
          }}
        >
          Show Details
        </Button>

        <Button
          onClick={() => deleteOrder(order.id)}
          color="danger"
          style={{ marginLeft: "8px" }} 
        >
          Delete Order
        </Button>
      </CardBody>
    </Card>
  );
}