import boto3
import json

def lambda_handler(event, context):
    # Initialize Bedrock client
    bedrock = boto3.client('bedrock-runtime', region_name='us-east-1')
    
    try:
        # Sample Bedrock invocation (adjust model ID as needed)
        response = bedrock.invoke_model(
            modelId='amazon.titan-text-express-v1',
            body=json.dumps({
                "inputText": "Explain serverless architecture in one sentence",
                "textGenerationConfig": {
                    "maxTokenCount": 100,
                    "temperature": 0.7,
                    "topP": 0.9
                }
            })
        )
        
        response_body = json.loads(response['body'].read())
        generated_text = response_body['results'][0]['outputText']
        
        return {
            'statusCode': 200,
            'body': generated_text
        }
        
    except Exception as e:
        return {
            'statusCode': 500,
            'body': f"Error: {str(e)}"
        }