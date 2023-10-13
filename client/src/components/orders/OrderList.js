import React, { useState, useEffect } from "react";
import { getOrders } from "../../managers/orderManager.js";
import OrderTicket from "./OrderTicket.js";

export default function OrderList({ setDetailsOrderId }) {
  const [orders, setOrders] = useState([]);

  const getAllOrders = () => {
    getOrders().then(setOrders); 
  };

  useEffect(() => {
    getAllOrders();
  }, []);

  return (
    <>
      <h2>Orders</h2>
      {orders.map((order) => (
        <OrderTicket
          order={order}
          setDetailsOrderId={setDetailsOrderId}
          key={`order-${orders.id}`}
        ></OrderTicket>
      ))}
    </>
  );
}

