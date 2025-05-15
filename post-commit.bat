#!/bin/bash
echo "Copying changes to stage directory..."

# Set correct paths
SOURCE_DIR="/c/Users/rakkanak/my_lambda_code_warror/bedrock-lambda-sample"
STAGE_DIR="/c/Users/rakkanak/my_lambda_code_warror/bedrock-lambda-stage"

# Copy files
cp -r "$SOURCE_DIR"/* "$STAGE_DIR"/

# Commit and push
cd "$STAGE_DIR"
git add .
git commit -m "Auto-commit from source at $(date)"
git push origin main