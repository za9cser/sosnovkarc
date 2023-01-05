import "../styles/globals.css";
import type { AppProps } from "next/app";
import { config } from "@fortawesome/fontawesome-svg-core";
import "@fortawesome/fontawesome-svg-core/styles.css";
import setupAxios from "../utils/axiosUtils/axiosSetup";
import axios from "axios";

config.autoAddCss = false;
setupAxios(axios);

export default function App({ Component, pageProps }: AppProps) {
    return <Component {...pageProps} />;
}
