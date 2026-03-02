# Mission #5 Assignment – Soccer Hobby (ASP.NET Core MVC)

This guide walks you through building the required two‑view ASP.NET Core MVC app about **soccer**. Follow each step in order.

---

## 1) Create the MVC project (if not already created)
1. In Visual Studio / Rider, create a new project.
2. Choose **ASP.NET Core Web App (Model-View-Controller)**.
3. Name it `Mission 5 Assignment_Noah_Blake` (or your class naming rules).
4. Click **Create**.

---

## 2) Add a soccer favicon (custom icon)
1. Find or create a small soccer icon (e.g., 16x16 or 32x32 `.ico` or `.png`).
2. Place it in `wwwroot` (example: `wwwroot/img/soccer.ico`).
3. Open `Views/Shared/_Layout.cshtml`.
4. Inside the `<head>` section, add:
   ```html
   <link rel="icon" type="image/x-icon" href="~/img/soccer.ico" />
   ```

---

## 3) Update shared layout for consistent title, nav, and footer
1. Open `Views/Shared/_Layout.cshtml`.
2. Set a consistent `<title>` (example: “Soccer Hobby | Mission 5”).
3. Add navigation links to both pages:
   - Home (Soccer page)
   - Calculator
4. Add a footer with copyright and your name, e.g.:
   ```html
   <footer class="footer text-center">
       <p>© 2026 Noah Blake | IS 413 Mission #5</p>
   </footer>
   ```

---

## 4) Build the Home page (Soccer hobby)
1. Open `Controllers/HomeController.cs`.
2. Ensure you have an action method for the home page (`Index`).
3. Go to `Views/Home/Index.cshtml`.
4. Add the following required elements:
   - **Heading** introducing your soccer site.
   - **At least two images** (place images in `wwwroot/img/`, then reference them).
   - **A few paragraphs** describing your soccer hobby.
   - **Navigation** to calculator page (could be in layout or a button on page).

Example image usage:
```html
<img src="~/img/soccer1.jpg" alt="Soccer action" />
<img src="~/img/soccer2.jpg" alt="Soccer ball" />
```

---

## 5) Add the Calculator page
### A) Controller action
1. In `HomeController.cs`, add:
   ```csharp
   public IActionResult Calculator()
   {
       return View();
   }
   ```

### B) Create the view
1. Create `Views/Home/Calculator.cshtml`.
2. Add these required elements:
   - Input box for **hours**
   - Non‑editable box for **rate per hour**
   - **Calculate** button
   - Output box for **total**
   - Navigation back to home

Example HTML layout:
```html
<label>Hours Needed:</label>
<input id="hours" type="number" min="1" />

<label>Rate per Hour:</label>
<input id="rate" type="text" value="30" readonly />

<button id="calcBtn">Calculate Total</button>

<label>Total:</label>
<input id="total" type="text" readonly />
```

---

## 6) Add jQuery calculation and validation
1. Create a JS file at `wwwroot/js/calculator.js`.
2. Add jQuery logic:
   - Read hours
   - Validate positive number
   - Multiply by hourly rate
   - Display total

Example:
```javascript
$(function () {
    $("#calcBtn").on("click", function () {
        const hours = parseFloat($("#hours").val());
        const rate = parseFloat($("#rate").val());

        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a positive number of hours.");
            return;
        }

        const total = hours * rate;
        $("#total").val(total.toFixed(2));
    });
});
```

3. Reference this JS file in `Calculator.cshtml` or in `_Layout.cshtml`:
```html
<script src="~/lib/jquery/dist/jquery.min.js"></script>
<script src="~/js/calculator.js"></script>
```

---

## 7) Ensure consistent look across pages
1. Use the same layout (`_Layout.cshtml`).
2. Update `wwwroot/css/site.css` for shared styling.
3. Keep heading, footer, colors, and navigation consistent.

---

## 8) Test the app locally
1. Run the project.
2. Check:
   - Title appears on tab
   - Favicon shows next to the title
   - Images load correctly
   - Calculator validates positive numbers
   - Total calculates correctly
   - Navigation works both directions

---

## 9) Push to GitHub (Public Repo)
1. Commit your changes.
2. Push to a **public** GitHub repository.
3. Submit the GitHub repo link in Learning Suite.

---

If you want, I can also build the pages and calculator for you directly in the project.
