using System;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000127 RID: 295
[Token(Token = "0x2000127")]
public class DescToggleView : MonoBehaviour
{
	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600057F RID: 1407 RVA: 0x00002FE8 File Offset: 0x000011E8
	// (set) Token: 0x0600057E RID: 1406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000048")]
	public int TabType
	{
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x23E6058", Offset = "0x23E6058", VA = "0x7BBCBE6058")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132E54", Offset = "0x1132E54")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x23E6050", Offset = "0x23E6050", VA = "0x7BBCBE6050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132E44", Offset = "0x1132E44")]
		private set
		{
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000580 RID: 1408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000049")]
	private UIWidget CurWidget
	{
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x23E6060", Offset = "0x23E6060", VA = "0x7BBCBE6060")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700004A")]
	public BoxCollider CurCollider
	{
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x23E60F4", Offset = "0x23E60F4", VA = "0x7BBCBE60F4")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000582 RID: 1410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700004B")]
	public UIToggleButton CurToggle
	{
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x23E6188", Offset = "0x23E6188", VA = "0x7BBCBE6188")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000583")]
	[Address(RVA = "0x23E621C", Offset = "0x23E621C", VA = "0x7BBCBE621C")]
	private void Start()
	{
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000584")]
	[Address(RVA = "0x23E62D4", Offset = "0x23E62D4", VA = "0x7BBCBE62D4")]
	private void OnClickToggle()
	{
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000585")]
	[Address(RVA = "0x23E6330", Offset = "0x23E6330", VA = "0x7BBCBE6330")]
	public void SetData(int tabType, string selectLabel, string unselectLabel, Action onSelect, [Optional] Action onUnselect, ETipsType tipsType = ETipsType.None, string selectBG = "", string unselectBG = "", string selectIcon = "", string unselectIcon = "")
	{
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000586")]
	[Address(RVA = "0x23E6790", Offset = "0x23E6790", VA = "0x7BBCBE6790")]
	public void AdjustWidth(int index, int width, float space)
	{
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000587")]
	[Address(RVA = "0x23E6910", Offset = "0x23E6910", VA = "0x7BBCBE6910")]
	public DescToggleView()
	{
	}

	// Token: 0x040004C1 RID: 1217
	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_Select;

	// Token: 0x040004C2 RID: 1218
	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_Unselect;

	// Token: 0x040004C3 RID: 1219
	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UILabel m_SelectLabel;

	// Token: 0x040004C4 RID: 1220
	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UISprite m_SelectIcon;

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UISprite m_SelectBG;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UILabel m_UnselectLabel;

	// Token: 0x040004C7 RID: 1223
	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UISprite m_UnselectIcon;

	// Token: 0x040004C8 RID: 1224
	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UISprite m_UnselectBG;

	// Token: 0x040004C9 RID: 1225
	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UITipsButton m_Reddot;

	// Token: 0x040004CA RID: 1226
	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11000CC", Offset = "0x11000CC")]
	private int <TabType>k__BackingField;

	// Token: 0x040004CB RID: 1227
	[Token(Token = "0x40004CB")]
	private const string DEFAULT_STRING = "";

	// Token: 0x040004CC RID: 1228
	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private UIWidget m_Widget;

	// Token: 0x040004CD RID: 1229
	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private BoxCollider m_Collider;

	// Token: 0x040004CE RID: 1230
	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private UIToggleButton m_Toggle;

	// Token: 0x040004CF RID: 1231
	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Action m_OnSelect;

	// Token: 0x040004D0 RID: 1232
	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Action m_OnUnselect;
}
