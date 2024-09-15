// Project15.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#include <iostream>
#include <memory>

template <typename T>
class LinkedList {
private:
    struct Node {
        T data;
        std::unique_ptr<Node> next;

        Node(T value) : data(value), next(nullptr) {}
    };

    std::unique_ptr<Node> head;
    std::size_t list_size;

public:
    LinkedList() : head(nullptr), list_size(0) {}

    void push_front(T value) {
        auto new_node = std::make_unique<Node>(value);
        new_node->next = std::move(head);
        head = std::move(new_node);
        ++list_size;
    }

    void push_back(T value) {
        auto new_node = std::make_unique<Node>(value);
        if (is_empty()) {
            head = std::move(new_node);
        }
        else {
            Node* current = head.get();
            while (current->next) {
                current = current->next.get();
            }
            current->next = std::move(new_node);
        }
        ++list_size;
    }

    void pop_front() {
        if (is_empty()) {
            throw std::runtime_error("List is empty");
        }
        head = std::move(head->next);
        --list_size;
    }
    void pop_back() {
        if (is_empty()) {
            throw std::runtime_error("List is empty");
        }
        if (head->next == nullptr) {
            head.reset();
        }
        else {
            Node* current = head.get();
            while (current->next->next) {
                current = current->next.get();
            }
            current->next.reset();
        }
        --list_size;
    }


    Node* find(T value) {
        Node* current = head.get();
        while (current) {
            if (current->data == value)
                return current;
            current = current->next.get();
        }
        return nullptr;
    }


    void remove(T value) {
        if (is_empty()) {
            throw std::runtime_error("List is empty");
        }

        if (head->data == value) {
            pop_front();
            return;
        }

        Node* current = head.get();
        while (current->next) {
            if (current->next->data == value) {
                current->next = std::move(current->next->next);
                --list_size;
                return;
            }
            current = current->next.get();
        }
        throw std::runtime_error("Value not found in the list");
    }


    void print() const {
        Node* current = head.get();
        while (current) {
            std::cout << current->data << " ";
            current = current->next.get();
        }
        std::cout << std::endl;
    }

    bool is_empty() const {
        return head == nullptr;
    }


    std::size_t size() const {
        return list_size;
    }
};

int main() {
    LinkedList<int> list;

    list.push_front(1);
    list.push_front(2);
    list.push_back(3);
    list.print(); 

    list.pop_front();
    list.print(); 

    list.pop_back();
    list.print(); 

    list.push_back(4);
    list.push_back(5);
    list.print(); 

    auto found = list.find(4);
    if (found) {
        std::cout << "Found: " << found->data << std::endl;
    }

    list.remove(1);
    list.print(); 

    std::cout << "Size: " << list.size() << std::endl; 
    std::cout << "Is empty: " << list.is_empty() << std::endl; 

    return 0;
}
