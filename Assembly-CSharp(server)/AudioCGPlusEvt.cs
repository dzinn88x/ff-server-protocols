using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000135 RID: 309
[Token(Token = "0x2000135")]
public class AudioCGPlusEvt : MonoBehaviour
{
	// Token: 0x060005D5 RID: 1493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x1F8AD3C", Offset = "0x1F8AD3C", VA = "0x7BBC78AD3C")]
	private void Awake()
	{
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x1F8ADFC", Offset = "0x1F8ADFC", VA = "0x7BBC78ADFC")]
	private void OnDestroy()
	{
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x1F8AEBC", Offset = "0x1F8AEBC", VA = "0x7BBC78AEBC")]
	private void ProcessCGEvt(params object[] data)
	{
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x1F8B0C8", Offset = "0x1F8B0C8", VA = "0x7BBC78B0C8")]
	private void OnEnable()
	{
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x1F8AEF8", Offset = "0x1F8AEF8", VA = "0x7BBC78AEF8")]
	private void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x1F8B104", Offset = "0x1F8B104", VA = "0x7BBC78B104")]
	public AudioCGPlusEvt()
	{
	}

	// Token: 0x040004FD RID: 1277
	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0x18")]
	public string voice_resourceid;

	// Token: 0x040004FE RID: 1278
	[Token(Token = "0x40004FE")]
	[FieldOffset(Offset = "0x20")]
	public string voice_resourceid_last;
}
