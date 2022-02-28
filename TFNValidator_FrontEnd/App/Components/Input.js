import React from 'react';
import TextField from "@mui/material/TextField";

function Input(props) {
    function setDisabledValue() {
        if (props.formState.status === "submitting") {
            return true;
        }
        return false;
    }
    function setCurrentInput(e) {
        console.log(e.target.value);
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
                onChange={setCurrentInput}
            />
        </>);
}

export default Input;