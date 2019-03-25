// PreorderTraversal.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <vector>
#include <stack>

using namespace std;

struct TreeNode {
	int val;
	TreeNode *left;
	TreeNode *right;
	TreeNode(int x) : val(x), left(NULL), right(NULL) {}
};

/*Function declarations*/
vector<int> preorderTraversal(TreeNode* root);

/*Main function*/
int main()
{
	/*Manual test case*/
	TreeNode *t = new TreeNode(1);
	TreeNode *t1 = new TreeNode(2);
	TreeNode *t2 = new TreeNode(3);

	t->right = t1;
	t1->left = t2;

	vector<int> values = preorderTraversal(t);

	/*Iterate through values to read the vector*/
	for (int i = 0; i < values.size(); i++) {
		cout << values[i];
	}

    return 0;
}

vector<int> preorderTraversal(TreeNode* root) {
	vector<int> values;
	stack<TreeNode *> nodes;

	/*If TreeNode is null, return an empty vector*/
	if (root == NULL) {
		return values;
	}

	/*Pushes the current position of the node*/
	nodes.push(root);

	/*While the stack is empty*/
	while (!nodes.empty()) {
		/*Adds the value of the first element into the vector, then pops it from the stack*/
		root = nodes.top();
		values.push_back(root->val);
		nodes.pop();

		/*Right is pushed first into the stack so the left paths will be popped first*/
		if (root->right != NULL) {
			nodes.push(root->right);
		}

		if (root->left != NULL) {
			nodes.push(root->left);
		}

	}

	return values;

}

