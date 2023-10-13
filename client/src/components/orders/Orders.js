import { useState } from "react";
import OrderDetails from "./OrderDetail.js";
import OrderList from "./OrderList.js";

export default function Orders() {
        const [detailsOrderId, setDetailsOrderId] = useState(null);

    return (
        <div className="container">
          <div className="row">
            <div className="col-sm-8">
              <OrderList setDetailsOrderId={setDetailsOrderId} />
            </div>
            <div className="col-sm-4">
              <OrderDetails detailsOrderId={detailsOrderId} />
            </div>
          </div>
        </div>
      );
    }