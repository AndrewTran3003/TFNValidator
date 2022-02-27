import React, { useState } from "react";
import Alert from "@mui/material/Alert";


function StatusSuccess() {
    const [display, setDisplay] = useState("none");
    const style = {
        display: display
    }
    return (
        <Alert sx={style} severity="success"></Alert>);
}
export default StatusSuccess;