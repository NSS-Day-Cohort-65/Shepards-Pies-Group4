import { useEffect, useState } from "react";
import { Button, Form, FormGroup, Input, Label } from "reactstrap";
import { useNavigate } from "react-router-dom";

export default function CreateOrder({ loggedInUser }) {
  const [description, setDescription] = useState("");
  const [pizzaSizeId, setPizzaSizeId] = useState(0);
  const [pizzaSizes, setPizzasSizes] = useState([]);

  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();
    const newOrder = {
      userProfileId,
      deliveryDriverId,
      timePlaced,
      pizzas
    };

    createOrder(newOrder).then(() => {
      navigate("/orders");
    });
  };

  return (
    <>
      <h2>Create an Order</h2>
      <Form>
        <FormGroup>
          <Label>Description</Label>
          <Input
            type="text"
            value={description}
            onChange={(e) => {
              setDescription(e.target.value);
            }}
          />
        </FormGroup>
        <FormGroup>
          <Label>Pizza</Label>
          <Input
            type="select"
            value={pizzaId}
            onChange={(e) => {
              setPizzaId(parseInt(e.target.value));
            }}
          >
            <option value={0}>Choose a Size</option>
            {pizzaSize.map((ps) => (
              <option
                key={ps.id}
                value={ps.id}
              >{`${ps.owner.name} - ${b.brand} - ${b.color}`}</option>
            ))}
          </Input>
        </FormGroup>
        <Button onClick={handleSubmit} color="primary">
          Submit
        </Button>
      </Form>
    </>
  );
}
