class Node
  attr_accessor :value, :left, :right

  def initialize(value)
    @value = value
    @left = nil
    @right = nil
  end
end

class BinarySearchTree
  attr_accessor :root

  def initialize
    @root = nil
  end

  # Insert a value into the BST
  def insert(value)
    if @root.nil?
      @root = Node.new(value)
    else
      insert_node(@root, value)
    end
  end

  # Delete a value from the BST
  def delete(value)
    delete_node(@root, value)
  end

  # Search for a value in the BST
  def search(value)
    search_node(@root, value)
  end

  private

  # Recursive helper method to insert a value into the BST
  def insert_node(node, value)
    if value < node.value
      if node.left.nil?
        node.left = Node.new(value)
      else
        insert_node(node.left, value)
      end
    elsif value > node.value
      if node.right.nil?
        node.right = Node.new(value)
      else
        insert_node(node.right, value)
      end
    end
  end

  # Recursive helper method to delete a value from the BST
  def delete_node(node, value)
    return node if node.nil?

    if value < node.value
      node.left = delete_node(node.left, value)
    elsif value > node.value
      node.right = delete_node(node.right, value)
    else
      if node.left.nil? && node.right.nil?
        node = nil
      elsif node.left.nil?
        node = node.right
      elsif node.right.nil?
        node = node.left
      else
        min_node = find_min_node(node.right)
        node.value = min_node.value
        node.right = delete_node(node.right, min_node.value)
      end
    end

    node
  end

  # Recursive helper method to search for a value in the BST
  def search_node(node, value)
    return false if node.nil?

    if value < node.value
      search_node(node.left, value)
    elsif value > node.value
      search_node(node.right, value)
    else
      true
    end
  end

  # Helper method to find the minimum value node in the BST
  def find_min_node(node)
    current = node
    current = current.left until current.left.nil?
    current
  end
end