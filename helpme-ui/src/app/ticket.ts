export interface Ticket {
    id?: number;
    name: string;
    email: string;
    title: string;
    body: string;
    ticketOpen: boolean;
    resolvedBy: string;

}
