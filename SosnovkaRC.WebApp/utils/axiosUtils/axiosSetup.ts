import { AxiosStatic } from "axios";

// export default function setupAxios(axios: AxiosStatic, store: any) {
//     axios.interceptors.request.use(
//         (request: AxiosRequestConfig<any>) => {
//             const {
//                 auth: { accessToken },
//             } = store.getState();

//             if (accessToken && request.headers) request.headers.Authorization = `Bearer ${accessToken}`;

//             request.url = `${API_URL}${request.url}`;

//             return request;
//         },
//         (error: any) => Promise.reject(error)
//     );

//     axios.interceptors.response.use(
//         (response: AxiosResponse<any, any>) => response,
//         (error: any) => {
//             if (error.response.status === 401) store.dispatch(actions.unauthorize());
//             return Promise.reject(error);
//         }
//     );
// }
