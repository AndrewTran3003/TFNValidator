import React from "react";
import Button from "@mui/material/Button";

function ValidateButton(props)
{
    function setFormCurrentState()
    {
        props.setFormState("submitting");
    }
    async function validateTfnNumber()
    {
        setFormCurrentState();
        const inputValue = props.inputValue;
        const url = `http://localhost:5001/Validate?tfnString=${inputValue}`;
        const response = await fetch(url);
        const responseText = await response.text();
        if (response.status === 200)
        {
            props.setFormState("success");
        }
        else
        {
            
            props.setFormState("error");
        }

    }
    return (
        <Button variant="contained" onClick={validateTfnNumber}>Validate</Button>
    );
}

export default ValidateButton;