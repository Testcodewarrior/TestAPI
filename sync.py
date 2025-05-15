import os
import shutil
from git import Repo

SOURCE_DIR = r"C:\Users\rakkanak\my_lambda_code_warror\bedrock-lambda-sample"
STAGE_DIR = r"C:\Users\rakkanak\my_lambda_code_warror\bedrock-lambda-stage"

def ignore_git(dir, files):
    return ['.git'] if '.git' in files else []

# Copy without .git
shutil.copytree(SOURCE_DIR, STAGE_DIR, dirs_exist_ok=True, ignore=ignore_git)

# Git operations
repo = Repo(STAGE_DIR)
repo.git.add(".")
repo.git.commit("-m", "Auto commit from sync script")
repo.git.pull("origin", "main","--rebase")
repo.git.push("origin", "main")
