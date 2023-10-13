import { Route, Routes } from "react-router-dom";

import { AuthorizedRoute } from "./auth/AuthorizedRoute";
import Login from "./auth/Login";
import Register from "./auth/Register";
import UserProfileList from "./userprofiles/UserProfileList.js";
import OrderList from "./orders/OrderList.js";
import Orders from "./orders/Orders.js";


export default function ApplicationViews({ loggedInUser, setLoggedInUser }) {
  return (
    <Routes>
      <Route path="/">
        <Route
          index
          element={
            <AuthorizedRoute loggedInUser={loggedInUser}>

            </AuthorizedRoute>
          }
        />
       <Route
          path="orders"
          element={
            <AuthorizedRoute loggedInUser={loggedInUser}>
              <Orders />
            </AuthorizedRoute>
          }
        />
      <Route
          path="createorder"
          element={
            <AuthorizedRoute loggedInUser={loggedInUser}>
              Filler Text
            </AuthorizedRoute>
          }
        />
        
         <Route
    path="employees"
    element={
    <AuthorizedRoute roles={["Admin"]} loggedInUser={loggedInUser}>
        <UserProfileList />
    </AuthorizedRoute>
    }
/>
        <Route
          path="login"
          element={<Login setLoggedInUser={setLoggedInUser} />}
        />
        <Route
          path="register"
          element={<Register setLoggedInUser={setLoggedInUser} />}
        />
      </Route>
      <Route path="*" element={<p>Whoops, nothing here...</p>} />
    </Routes>
  );
}
