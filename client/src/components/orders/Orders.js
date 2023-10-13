import { useState } from "react";
import OrderDetails from "./OrderDetail.js";
import OrderList from "./OrderList.js";

export default function Orders() {

  return (
    <div className="container">
      <div className="row">
        <div className="col-sm-8">
          <OrderList />
        </div>
      </div>
    </div>
  );
}