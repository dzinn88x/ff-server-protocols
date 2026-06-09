using System;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

// Token: 0x020001B3 RID: 435
[Token(Token = "0x20001B3")]
public abstract class OverlayLibraryBase : MonoBehaviour
{
	// Token: 0x06000928 RID: 2344
	[Token(Token = "0x6000928")]
	public abstract void AddOverlayAsset(OverlayDataAsset overlay);

	// Token: 0x06000929 RID: 2345
	[Token(Token = "0x6000929")]
	public abstract OverlayData InstantiateOverlay(string name);

	// Token: 0x0600092A RID: 2346
	[Token(Token = "0x600092A")]
	public abstract OverlayData InstantiateOverlay(int nameHash);

	// Token: 0x0600092B RID: 2347
	[Token(Token = "0x600092B")]
	public abstract OverlayData InstantiateOverlay(string name, Color color);

	// Token: 0x0600092C RID: 2348
	[Token(Token = "0x600092C")]
	public abstract OverlayData InstantiateOverlay(int nameHash, Color color);

	// Token: 0x0600092D RID: 2349
	[Token(Token = "0x600092D")]
	public abstract OverlayDataAsset[] GetAllOverlayAssets();

	// Token: 0x0600092E RID: 2350
	[Token(Token = "0x600092E")]
	public abstract void UpdateDictionary();

	// Token: 0x0600092F RID: 2351
	[Token(Token = "0x600092F")]
	public abstract void ValidateDictionary();

	// Token: 0x06000930 RID: 2352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000930")]
	[Address(RVA = "0x22AB350", Offset = "0x22AB350", VA = "0x7BBCAAB350")]
	protected OverlayLibraryBase()
	{
	}
}
