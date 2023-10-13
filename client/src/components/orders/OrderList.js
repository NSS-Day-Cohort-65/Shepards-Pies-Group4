import React, { useState, useEffect } from "react";
import { getOrders } from "../../managers/orderManager.js";

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
      {orders ? (
        orders.map((order) => (
          <OrderList
            order={order}
            key={order.id}
            getAllOrders={getAllOrders}
          />
        ))
      ) : (
        <p>Loading...</p>
      )}
    </>
  );
  
}
