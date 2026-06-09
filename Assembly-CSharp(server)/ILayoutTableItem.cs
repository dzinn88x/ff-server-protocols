using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000128 RID: 296
[Token(Token = "0x2000128")]
public interface ILayoutTableItem
{
	// Token: 0x06000588 RID: 1416
	[Token(Token = "0x6000588")]
	Vector2 GetSize();

	// Token: 0x06000589 RID: 1417
	[Token(Token = "0x6000589")]
	void Init();

	// Token: 0x0600058A RID: 1418
	[Token(Token = "0x600058A")]
	void UnInit();

	// Token: 0x0600058B RID: 1419
	[Token(Token = "0x600058B")]
	bool SkipPadding();
}
