const apiUrl = "/api/order";

export const getOrders = () => {
  return fetch(apiUrl).then((res) => res.json());
};

export const getOrderById = (id) => {
  return fetch(`${apiUrl}/${id}`).then((res) => res.json());
};

