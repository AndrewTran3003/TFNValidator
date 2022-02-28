import React from "react";
import Button from "@mui/material/Button";

function ValidateButton(props)
{
    function setFormCurrentState()
    {
        console.log(props.setFormState);
        props.setFormState("submitting");
    }
    return (
        <Button variant="contained" onClick = {setFormCurrentState}>Validate</Button>
    );
}

export default ValidateButton;