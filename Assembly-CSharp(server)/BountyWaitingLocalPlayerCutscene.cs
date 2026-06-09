using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000016 RID: 22
[Token(Token = "0x2000016")]
public class BountyWaitingLocalPlayerCutscene : MonoBehaviour
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000005")]
	public AnimationClip ChooseClip
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1F9570C", Offset = "0x1F9570C", VA = "0x7BBC79570C")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1F941F8", Offset = "0x1F941F8", VA = "0x7BBC7941F8")]
	public void LoadAnimClip(bool isFemale)
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1F94644", Offset = "0x1F94644", VA = "0x7BBC794644")]
	public void UnloadAnimClip()
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1F95DFC", Offset = "0x1F95DFC", VA = "0x7BBC795DFC")]
	public BountyWaitingLocalPlayerCutscene()
	{
	}

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x18")]
	public int CutsceneIndex;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x20")]
	public string MaleAnimResID;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x28")]
	public string FemaleAnimResID;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x30")]
	private ResourceID m_ChooseID;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x38")]
	private AnimationClip m_ChooseClip;
}
