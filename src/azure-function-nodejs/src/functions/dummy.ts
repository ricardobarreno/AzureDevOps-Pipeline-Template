import { app, HttpRequest, HttpResponseInit, InvocationContext } from "@azure/functions";

export async function dummy(request: HttpRequest, context: InvocationContext): Promise<HttpResponseInit> {
    context.log(`Http function processed request for url "${request.url}"`);

    return {
        headers: {
            'Content-Type': 'application/json'
        },
        status: 200,
        body: JSON.stringify({ message: 'Hello World!' })
    };
};

app.http('dummy', {
    methods: ['GET'],
    authLevel: 'anonymous',
    handler: dummy
});
