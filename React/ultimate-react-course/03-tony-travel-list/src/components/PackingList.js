import { useState } from "react";
import Item from "./Item";

export default function PackingList({ items, onDeleteItem, onToggleItem, onClearList }) {
  const [sortBy, setSortBy] = useState("input");

  var sortedItems;

  if (sortBy === 'input') {
    sortedItems = items;
  }
  else if (sortBy === 'description') {
    sortedItems = items.slice().sort((a, b) => a.description.localeCompare(b.description));
  }
  else if (sortBy === 'packed') {
    sortedItems = items.slice().sort((a, b) => a.packed - Number(b.packed));
    //Se puede usar:
    //a.packed - b.packed
    //Number(a.packed) - Number(b.packed)
  }

  return (
    <div>
      <ul className="list">
        {sortedItems.map(
          (item) => <Item
            item={item}
            onDeleteItem={onDeleteItem}
            onToggleItem={onToggleItem}
            key={item.id} />
        )}
      </ul>

      <div className="actions">
        <select value={sortBy} onChange={(e) => setSortBy(e.target.value)}>
          <option value="input">Sort by input order</option>
          <option value="description">Sort by description</option>
          <option value="packed">Sort by packed status</option>
        </select>

        <button onClick={onClearList}>Clear list</button>
      </div>
    </div>
  );
}
