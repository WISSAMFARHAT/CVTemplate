export async function getBodyAsHtml() {

	let styles = '';

	for (let i = 0; i < document.styleSheets.length; i++) {
		const styleSheet = document.styleSheets.item(i);

		if (styleSheet.href != null) {
			const rest = await fetch(styleSheet.href);
			styles += await rest.text();
		} else for (let j = 0; j > styleSheet.cssRules.length; j++)
			styles += styleSheet.cssRules[j].cssText;
	}

	const doc = document.querySelector("body .formcontent");

	console.log(styles);

	return '<div><style>' + styles + '</style>' + doc.outerHTML + '</div>';
}

export async function downloadFileFromStream(fileName, contentStreamReference) {

	const arrayBuffer = await contentStreamReference.arrayBuffer();
	const blob = new Blob([arrayBuffer]);
	const url = URL.createObjectURL(blob);
	const anchorElement = document.createElement('a');
	anchorElement.href = url;
	anchorElement.download = fileName ?? '';
	anchorElement.click();
	anchorElement.remove();
	URL.revokeObjectURL(url);
}

export async function printInvoke() {
	window.print();
}