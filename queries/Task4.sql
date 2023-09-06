SELECT DISTINCT parent.id,
	CASE
		WHEN parent.p_id IS NULL THEN 'Root'
		WHEN child.id IS NULL THEN 'Leaf'
		ELSE 'Inner'
	END AS type
FROM Tree AS parent
LEFT JOIN Tree AS child
	ON parent.id = child.p_id
ORDER BY parent.id;