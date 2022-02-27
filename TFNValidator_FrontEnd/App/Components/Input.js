import React from 'react';
import TextField from "@mui/material/TextField";

function Input()
{
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
            />
        </>);
}

export default Input;