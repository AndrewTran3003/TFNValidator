import React, { useState } from "react";
import CircularProgress from "@mui/material/CircularProgress";

function ProgressIndicator(props) {


    const style = {
        display: props.formState === "submitting" ? "block" : "none"
    }
    return (
        < >
            <CircularProgress sx={style} />
        </>
    );
}
export default ProgressIndicator;