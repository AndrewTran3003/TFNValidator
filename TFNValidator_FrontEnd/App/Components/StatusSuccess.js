import React from "react";
import Alert from "@mui/material/Alert";


function StatusSuccess() {
    return (
        <Alert severity="success">{props.validationMessage}</Alert>);
}
export default StatusSuccess;