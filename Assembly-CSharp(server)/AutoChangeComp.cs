using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000146 RID: 326
[Token(Token = "0x2000146")]
public class AutoChangeComp : MonoBehaviour
{
	// Token: 0x06000634 RID: 1588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000634")]
	[Address(RVA = "0x1F8B5A0", Offset = "0x1F8B5A0", VA = "0x7BBC78B5A0")]
	public void SetData(bool start = true)
	{
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000635")]
	[Address(RVA = "0x1F8B77C", Offset = "0x1F8B77C", VA = "0x7BBC78B77C")]
	public void Clear()
	{
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000636")]
	[Address(RVA = "0x1F8B96C", Offset = "0x1F8B96C", VA = "0x7BBC78B96C")]
	private void OnDisable()
	{
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000637")]
	[Address(RVA = "0x1F8B970", Offset = "0x1F8B970", VA = "0x7BBC78B970")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000638")]
	[Address(RVA = "0x1F8B848", Offset = "0x1F8B848", VA = "0x7BBC78B848")]
	private void DoAction()
	{
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000639")]
	[Address(RVA = "0x1F8B974", Offset = "0x1F8B974", VA = "0x7BBC78B974")]
	public AutoChangeComp()
	{
	}

	// Token: 0x04000546 RID: 1350
	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] m_Items;

	// Token: 0x04000547 RID: 1351
	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_Interval;

	// Token: 0x04000548 RID: 1352
	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x24")]
	private int m_CurIndex;

	// Token: 0x04000549 RID: 1353
	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x28")]
	private uint m_CallID;
}
