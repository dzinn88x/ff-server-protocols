using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D0 RID: 464
[Token(Token = "0x20001D0")]
public abstract class ABLevelObjectInfo
{
	// Token: 0x0600099D RID: 2461
	[Token(Token = "0x600099D")]
	public new abstract EABLevelObjectInfoType GetType();

	// Token: 0x0600099E RID: 2462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099E")]
	[Address(RVA = "0x1F82B20", Offset = "0x1F82B20", VA = "0x7BBC782B20")]
	public void SerializedData(ref BinaryWriter writer)
	{
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099F")]
	[Address(RVA = "0x1F82B84", Offset = "0x1F82B84", VA = "0x7BBC782B84")]
	public void UnSerializedData(ref BinaryReader reader)
	{
	}

	// Token: 0x060009A0 RID: 2464
	[Token(Token = "0x60009A0")]
	protected abstract void OnSerializedData(ref BinaryWriter writer);

	// Token: 0x060009A1 RID: 2465
	[Token(Token = "0x60009A1")]
	protected abstract void OnUnSerializedData(ref BinaryReader reader);

	// Token: 0x060009A2 RID: 2466
	[Token(Token = "0x60009A2")]
	public abstract void ApplyData(GameObject inst_object);

	// Token: 0x060009A3 RID: 2467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x1F82BE4", Offset = "0x1F82BE4", VA = "0x7BBC782BE4")]
	protected ABLevelObjectInfo()
	{
	}

	// Token: 0x0400092D RID: 2349
	[Token(Token = "0x400092D")]
	[FieldOffset(Offset = "0x10")]
	public int GoInfoIndex;
}
