using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D2 RID: 210
[Token(Token = "0x20000D2")]
public class UIHUDArmsRacePointItem : MonoBehaviour
{
	// Token: 0x0600038C RID: 908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038C")]
	[Address(RVA = "0x1CA9300", Offset = "0x1CA9300", VA = "0x7BBC4A9300")]
	private void Start()
	{
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038D")]
	[Address(RVA = "0x1CA9304", Offset = "0x1CA9304", VA = "0x7BBC4A9304")]
	public void Empty()
	{
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038E")]
	[Address(RVA = "0x1CA93C4", Offset = "0x1CA93C4", VA = "0x7BBC4A93C4")]
	public void Light()
	{
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038F")]
	[Address(RVA = "0x1CA9438", Offset = "0x1CA9438", VA = "0x7BBC4A9438")]
	public void Ban()
	{
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x1CA937C", Offset = "0x1CA937C", VA = "0x7BBC4A937C")]
	public void UnBan()
	{
	}

	// Token: 0x06000391 RID: 913 RVA: 0x000029B8 File Offset: 0x00000BB8
	[Token(Token = "0x6000391")]
	[Address(RVA = "0x1CA9484", Offset = "0x1CA9484", VA = "0x7BBC4A9484")]
	public bool IsBan()
	{
		return default(bool);
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000392")]
	[Address(RVA = "0x1CA948C", Offset = "0x1CA948C", VA = "0x7BBC4A948C")]
	public UIHUDArmsRacePointItem()
	{
	}

	// Token: 0x04000354 RID: 852
	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x18")]
	public GameObject EmptyContainer;

	// Token: 0x04000355 RID: 853
	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LightingContainer;

	// Token: 0x04000356 RID: 854
	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsBanned;

	// Token: 0x04000357 RID: 855
	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x29")]
	private bool m_IsEmpty;
}
