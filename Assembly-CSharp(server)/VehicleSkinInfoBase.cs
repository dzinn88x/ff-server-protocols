using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C1 RID: 449
[Token(Token = "0x20001C1")]
public abstract class VehicleSkinInfoBase : MonoBehaviour
{
	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000980 RID: 2432 RVA: 0x00003CF0 File Offset: 0x00001EF0
	// (set) Token: 0x06000981 RID: 2433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000AD")]
	public uint SkinResID
	{
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x218C978", Offset = "0x218C978", VA = "0x7BBC98C978")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1133260", Offset = "0x1133260")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x218C980", Offset = "0x218C980", VA = "0x7BBC98C980")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1133270", Offset = "0x1133270")]
		set
		{
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000982 RID: 2434
	[Token(Token = "0x170000AE")]
	public abstract Transform BodyModel { [Token(Token = "0x6000982")] get; }

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000983 RID: 2435
	[Token(Token = "0x170000AF")]
	public abstract List<Transform> WheelModels { [Token(Token = "0x6000983")] get; }

	// Token: 0x06000984 RID: 2436
	[Token(Token = "0x6000984")]
	public abstract void SetSkinState(bool is_show);

	// Token: 0x06000985 RID: 2437
	[Token(Token = "0x6000985")]
	public abstract void ClearSkinAttached();

	// Token: 0x06000986 RID: 2438
	[Token(Token = "0x6000986")]
	public abstract void EnableBrakeLightsEffect(bool enable);

	// Token: 0x06000987 RID: 2439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000987")]
	[Address(RVA = "0x218C970", Offset = "0x218C970", VA = "0x7BBC98C970")]
	protected VehicleSkinInfoBase()
	{
	}

	// Token: 0x040008E6 RID: 2278
	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11009B8", Offset = "0x11009B8")]
	private uint <SkinResID>k__BackingField;
}
