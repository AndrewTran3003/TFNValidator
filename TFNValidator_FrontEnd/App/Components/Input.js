import React from 'react';
import TextField from "@mui/material/TextField";

function Input(props) {
    function setDisabledValue() {
        console.log(props.formState);
        if (props.formState.status === "active") {
            console.log("input is active");
            return false;
        }
        console.log("input is disabled");

        return true;
    }
    function setCurrentInput(e) {
        props.setInputValue(e.target.value);
    }
    return (
        <>
            <TextField
                autoFocus
                margin="dense"
                id="tfn-input"
                label="Tax File Number"
                type="text"
                fullWidth
                variant="standard"
                disabled={setDisabledValue()}
                onKeyPress={setCurrentInput}
            />
        </>);
}

export default Input;