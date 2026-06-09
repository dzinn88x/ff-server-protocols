using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000131 RID: 305
[Token(Token = "0x2000131")]
internal class AnimAudioEvt : MonoBehaviour
{
	// Token: 0x060005B7 RID: 1463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x1F890CC", Offset = "0x1F890CC", VA = "0x7BBC7890CC")]
	private void OnDestroy()
	{
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x1F890D4", Offset = "0x1F890D4", VA = "0x7BBC7890D4")]
	public void PlayAnimAudioBackGroundEvt(string voice_resourceid)
	{
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x1F892AC", Offset = "0x1F892AC", VA = "0x7BBC7892AC")]
	public void PlayAnimAudioLoopBackGroundEvt(string voice_resourceid)
	{
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x1F89484", Offset = "0x1F89484", VA = "0x7BBC789484")]
	public void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x1F89650", Offset = "0x1F89650", VA = "0x7BBC789650")]
	public void StopEvtShot()
	{
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x1F8971C", Offset = "0x1F8971C", VA = "0x7BBC78971C")]
	public void PlayAnimOnlyOneShotEvt(string voice_resourceid)
	{
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x1F89928", Offset = "0x1F89928", VA = "0x7BBC789928")]
	public void ResumeAudioVolume()
	{
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x1F899E0", Offset = "0x1F899E0", VA = "0x7BBC7899E0")]
	public void ReduceAudioVolume(float volumerate)
	{
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x1F89AA0", Offset = "0x1F89AA0", VA = "0x7BBC789AA0")]
	public void DispatchAnimEvent(string eventName)
	{
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x1F89BD0", Offset = "0x1F89BD0", VA = "0x7BBC789BD0")]
	public AnimAudioEvt()
	{
	}

	// Token: 0x040004FB RID: 1275
	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x18")]
	private GameObject CurrentPlayShot;
}
