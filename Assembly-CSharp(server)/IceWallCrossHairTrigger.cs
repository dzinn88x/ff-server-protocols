using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000028 RID: 40
[Token(Token = "0x2000028")]
public class IceWallCrossHairTrigger : MonoBehaviour
{
	// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x24CADD4", Offset = "0x24CADD4", VA = "0x7BBCCCADD4")]
	private void OnDisable()
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x24CAF28", Offset = "0x24CAF28", VA = "0x7BBCCCAF28")]
	private void Start()
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x24CB084", Offset = "0x24CB084", VA = "0x7BBCCCB084")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x24CB1E0", Offset = "0x24CB1E0", VA = "0x7BBCCCB1E0")]
	private void OnPlayerDead(params object[] data)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x24CB36C", Offset = "0x24CB36C", VA = "0x7BBCCCB36C")]
	private void OnVehicleDead(params object[] data)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x24CB520", Offset = "0x24CB520", VA = "0x7BBCCCB520")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x24CB928", Offset = "0x24CB928", VA = "0x7BBCCCB928")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600008F RID: 143 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x17000007")]
	public bool AreaOccupied
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x24CBC78", Offset = "0x24CBC78", VA = "0x7BBCCCBC78")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x24CAE60", Offset = "0x24CAE60", VA = "0x7BBCCCAE60")]
	private void OnObjInsideChanged()
	{
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x24CBC80", Offset = "0x24CBC80", VA = "0x7BBCCCBC80")]
	public IceWallCrossHairTrigger()
	{
	}

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x18")]
	public bool CheckPlayer;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x19")]
	public bool CheckVehicle;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<{QAb\u0082~u, List<Collider>> mPlayersInside;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, List<Collider>> mVehiclesInside;

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x30")]
	private bool mAreaOccupied;
}
